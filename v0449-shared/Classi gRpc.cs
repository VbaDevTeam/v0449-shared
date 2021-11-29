class v0449gRpcSvcImpl : v0449gRpcSvc.v0449gRpcSvcBase
  {
    V v = new();
    public override Task<dataAnswer> getRtData(dataRequest request, ServerCallContext context)
    {
      return Task.FromResult(new dataAnswer { Message = "Adesso puoi andare affanculo, " + request.Name });
    }

    public override Task<data2Hmi> xchRtData(data2Plc request, ServerCallContext context)
    {
      TextReader reader = new StringReader(request.XmlSer);
      XmlSerializer ser = new XmlSerializer(typeof(ComRt2Plc));
      v.comRt2Plc = (ComRt2Plc)ser.Deserialize(reader);


      StringWriter outApp = new StringWriter(new StringBuilder());
      XmlSerializer serApp = new XmlSerializer(typeof(ComRt2Hmi));
      serApp.Serialize(outApp, v.comRt2Hmi);
      string appData = outApp.ToString();

      return Task.FromResult(new data2Hmi { XmlSer = appData });
    }

    public override Task<data2HmiJs> xchRtDataJs(data2PlcJs request, ServerCallContext context)
    {
      v.comRt2Plc = System.Text.Json.JsonSerializer.Deserialize<ComRt2Plc>(request.JsSer);

      //Utilizzo libreria Newtonsoft.Json
      var options = new JsonSerializerOptions { WriteIndented = true };
      
      string jsonString = System.Text.Json.JsonSerializer.Serialize(v.comRt2Hmi, options);
      return Task.FromResult(new data2HmiJs { JsSer = jsonString });
    }
  }

class v0449MicroSClient
  {
    public event getProgressRepo gProgressRepo;
    public event getEndGenerRepo gEndGenerRepo;

    readonly v0449gRpcMicroS.v0449gRpcMicroSClient client;

    public v0449MicroSClient(v0449gRpcMicroS.v0449gRpcMicroSClient client)
    {
      this.client = client;
    }



    //public async Task reqGen(string initDate, string endDate, int reportId, int userId, string path)
    public svcReportResponse reqGen(string initDate, string endDate, int reportId, int userId, string path)
    {
      try
      {
        //Log("*** ListFeatures: lowLat={0} lowLon={1} hiLat={2} hiLon={3}", lowLat, lowLon, hiLat,
        //    hiLon);

        svcReportRequest request = new svcReportRequest
        { 
          InitRepo = initDate,
          EndRepo = endDate,
          IdReport = reportId, 
          IdUser = userId,
          PathToSave = path
        };

        svcReportResponse response = client.reqGen(request);

        return response;
      }
      catch (RpcException e)
      {
        //Log("RPC failed " + e);
        throw;
      }
    }


    public svcReportResponse reqStatus(int cmdReq)
    {
      try
      {
        //Log("*** ListFeatures: lowLat={0} lowLon={1} hiLat={2} hiLon={3}", lowLat, lowLon, hiLat,
        //    hiLon);

        svcStatusRequest request = new svcStatusRequest
        {
          MyRequest = cmdReq,
        };

        svcReportResponse response = client.reqStatus(request);

        return response;
      }
      catch (RpcException e)
      {
        //Log("RPC failed " + e);
        throw;
      }
    }





  }
