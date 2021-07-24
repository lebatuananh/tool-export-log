using Newtonsoft.Json;

namespace Tool.ExportLog.Shared
{

    [JsonObject(MemberSerialization.OptOut)]
    public class Result
    {
        public string CurrentDate { get; set; }
        public string BksNo { get; set; }
        public string Status { get; set; } // 1|0 Success|Not foud
        //public string LastEmployeeId { get; set; }
    }
}
