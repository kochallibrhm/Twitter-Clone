namespace TwitterClone.API.Models
{
    public interface IBaseReturnType
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}