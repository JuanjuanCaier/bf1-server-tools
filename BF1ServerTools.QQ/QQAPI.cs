using BF1ServerTools.QQ.Resp;

using RestSharp;

namespace BF1ServerTools.QQ;

public static class QQAPI
{
    private const string host = "http://127.0.0.1:65501";

    private static readonly RestClient client;

    static QQAPI()
    {
        if (client == null)
        {
            var options = new RestClientOptions(host)
            {
                MaxTimeout = 5000,
                ThrowOnAnyError = true
            };
            client = new RestClient(options);
        }
    }

    /// <summary>
    /// ��ȡQQȺ�б�
    /// </summary>
    /// <returns></returns>
    public static async Task<RespMsg> GetGroupList()
    {
        var sw = new Stopwatch();
        sw.Start();
        var respMsg = new RespMsg();

        try
        {
            var request = new RestRequest("/get_group_list");

            var response = await client.ExecuteGetAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
                respMsg.IsSuccess = true;

            respMsg.Message = response.Content;
        }
        catch (Exception ex)
        {
            respMsg.Message = ex.Message;
        }

        sw.Stop();
        respMsg.ExecTime = sw.Elapsed.TotalSeconds;

        return respMsg;
    }

    /// <summary>
    /// ������Ϣ
    /// </summary>
    /// <param name="user_id">�Է�QQ��</param>
    /// <param name="message">Ҫ���͵�����</param>
    /// <returns></returns>
    public static async Task<RespMsg> SendMsg(long user_id, string message)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respMsg = new RespMsg();

        try
        {
            var request = new RestRequest("/send_msg")
                .AddQueryParameter("message_type", "private")
                .AddQueryParameter("user_id", user_id)
                .AddQueryParameter("message", message)
                .AddQueryParameter("auto_escape", false);

            var response = await client.ExecuteGetAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
                respMsg.IsSuccess = true;

            respMsg.Message = response.Content;
        }
        catch (Exception ex)
        {
            respMsg.Message = ex.Message;
        }

        sw.Stop();
        respMsg.ExecTime = sw.Elapsed.TotalSeconds;

        return respMsg;
    }

    /// <summary>
    /// ����Ⱥ��Ϣ
    /// </summary>
    /// <param name="group_id">Ⱥ��</param>
    /// <param name="message">Ҫ���͵�����</param>
    /// <returns></returns>
    public static async Task<RespMsg> SendGroupMsg(long group_id, string message)
    {
        var sw = new Stopwatch();
        sw.Start();
        var respMsg = new RespMsg();

        try
        {
            var request = new RestRequest("/send_group_msg")
                .AddQueryParameter("group_id", group_id)
                .AddQueryParameter("message", message)
                .AddQueryParameter("auto_escape", false);

            var response = await client.ExecuteGetAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
                respMsg.IsSuccess = true;

            respMsg.Message = response.Content;
        }
        catch (Exception ex)
        {
            respMsg.Message = ex.Message;
        }

        sw.Stop();
        respMsg.ExecTime = sw.Elapsed.TotalSeconds;

        return respMsg;
    }
}
