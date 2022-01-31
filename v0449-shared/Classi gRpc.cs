using System;
using System.Collections.Generic;
using VbaLib;
using System.Text;
using Grpc.Core;
using V0449GRpc;
using V0449GRpcMicroS;
using V0449GRpcCell;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Linq;
using Newtonsoft.Json;

namespace v0449_shared
{
  class v0449gRpcSvcImpl : v0449gRpcSvc.v0449gRpcSvcBase
  {
    V v = new();
    // public override Task<dataAnswer> getRtData(dataRequest request, ServerCallContext context)
    // {
    //   return Task.FromResult(new dataAnswer { Message = "Adesso puoi andare affanculo, " + request.Name });
    // }
    //
    // public override Task<data2Hmi> xchRtData(data2Plc request, ServerCallContext context)
    // {
    //   TextReader reader = new StringReader(request.XmlSer);
    //   XmlSerializer ser = new XmlSerializer(typeof(ComRt2Plc));
    //   v.comRt2Plc = (ComRt2Plc)ser.Deserialize(reader);
    //
    //
    //   StringWriter outApp = new StringWriter(new StringBuilder());
    //   XmlSerializer serApp = new XmlSerializer(typeof(ComRt2Hmi));
    //   serApp.Serialize(outApp, v.comRt2Hmi);
    //   string appData = outApp.ToString();
    //
    //   return Task.FromResult(new data2Hmi { XmlSer = appData });
    // }
    //
    // public override Task<data2HmiJs> xchRtDataJs(data2PlcJs request, ServerCallContext context)
    // {
    //   v.comRt2Plc = System.Text.Json.JsonSerializer.Deserialize<ComRt2Plc>(request.JsSer);
    //
    //   //Utilizzo libreria Newtonsoft.Json
    //   var options = new JsonSerializerOptions { WriteIndented = true };
    //
    //   string jsonString = System.Text.Json.JsonSerializer.Serialize(v.comRt2Hmi, options);
    //   return Task.FromResult(new data2HmiJs { JsSer = jsonString });

    public override Task<data2HmiJs> xchRtDataJsSlave(slaveReq2Plc request, ServerCallContext context)
    {
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
        svcReportResponse response = new svcReportResponse { ActiveToken = "-errore", MyMessage = e.Message };
        return response;

      }
    }
    public svcReportResponse reqGen(int reportId, int userId, string path)
    {
      try
      {
        //Log("*** ListFeatures: lowLat={0} lowLon={1} hiLat={2} hiLon={3}", lowLat, lowLon, hiLat,
        //    hiLon);

        svcReportRequest request = new svcReportRequest
        {
          InitRepo = "2099-12-09 00:00:00",
          EndRepo = "1970-12-09 00:00:00",
          IdReport = reportId,
          IdUser = userId,
          PathToSave = path
        };

        svcReportResponse response = client.reqGen(request);

        return response;
      }
      catch (RpcException e)
      {
        svcReportResponse response = new svcReportResponse { ActiveToken = "-errore", MyMessage = e.Message };
        return response;

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
        svcReportResponse response = new svcReportResponse { ActiveToken = "-errore", MyMessage = e.Message };
        return response;
      }
    }
  }

  public class v0449CellaClient
  {
    readonly v0449gRpcCell.v0449gRpcCellClient client;

    public v0449CellaClient(v0449gRpcCell.v0449gRpcCellClient client)
    {
      this.client = client;
    }

    public svcProcessValueResponse getProcessValue()
    {
      svcProcessValueRequest request = new svcProcessValueRequest
      {
        StsRequest = 1,
      };

      svcProcessValueResponse response = client.getProcessValue(request);
      return response;
    }

    public svcSetpointResponse setSetpoint(int spTemp, int spUmid, int cmdReq)
    {
      try
      {
        svcSetpointRequest request = new svcSetpointRequest
        {
          CmdReq = cmdReq,
          SpTemp = spTemp,
          SpUmid = spUmid,
        };
        svcSetpointResponse response = client.setSetpoint(request);
        return response;
      }
      catch (RpcException ex)
      {
        svcSetpointResponse response = new svcSetpointResponse();
        return response;
      }
    }


  }



}