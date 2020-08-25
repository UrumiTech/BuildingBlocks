namespace Phm.MobileSp.BuildingBlocks.Dto
{
    public class Response<T>
    {
        public Response()
        {
            
        }

        public Response(T dataObject)
        {
            Data = dataObject;
        }

        

        public T Data { get; set; }
    }
}