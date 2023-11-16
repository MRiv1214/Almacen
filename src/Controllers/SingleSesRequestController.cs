using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class SingleSesRequestController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<SingleSesRequest>? singleSesRequestRepository;
    public SingleSesRequestController(IRepository<SingleSesRequest>? singleSesRequestRepository)
    {
        this.singleSesRequestRepository = singleSesRequestRepository;
    }
    public long CreateSingleSesRequest(SingleSesRequestDto singleSesRequestDto)
    {
        var singleSesRequest = new SingleSesRequest
        {
            RequestId = singleSesRequestDto.RequestId,
            Payroll = singleSesRequestDto.Payroll,
            Level = singleSesRequestDto.Level,
            Period = singleSesRequestDto.Period,
        };
        singleSesRequestRepository?.Create(singleSesRequest);
        return singleSesRequest.SinSesReqId;
    }
    public IEnumerable<SingleSesRequest> GetAllSingleSesRequests()
    {
        var singleSesRequests = singleSesRequestRepository?.GetAll();
        if (singleSesRequests == null)
        {
            return new List<SingleSesRequest>();
        }
        return singleSesRequests.Select(singleSesRequest => new SingleSesRequest
        {
            SinSesReqId = singleSesRequest.SinSesReqId,
            RequestId = singleSesRequest.RequestId,
            Payroll = singleSesRequest.Payroll,
            Level = singleSesRequest.Level,
            Period = singleSesRequest.Period,
        });
    }
    public SingleSesRequest GetSingleSesRequestById(long id)
    {
        var singleSesRequest = (singleSesRequestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new SingleSesRequest
        {
            SinSesReqId = singleSesRequest.SinSesReqId,
            RequestId = singleSesRequest.RequestId,
            Payroll = singleSesRequest.Payroll,
            Level = singleSesRequest.Level,
            Period = singleSesRequest.Period,
        };
    }
    public void RemoveSingleSesRequest(long id)
    {
        var singleSesRequest = (singleSesRequestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        singleSesRequestRepository?.Remove(singleSesRequest);
    }
    public void UpdateSingleSesRequest(SingleSesRequest singleSesRequest)
    {
        var singleSesRequestToUpdate = singleSesRequestRepository?.GetById(singleSesRequest.SinSesReqId)?? throw new ArgumentException("Invalid id");
        singleSesRequestToUpdate.RequestId = singleSesRequest.RequestId;
        singleSesRequestToUpdate.Payroll = singleSesRequest.Payroll;
        singleSesRequestToUpdate.Level = singleSesRequest.Level;
        singleSesRequestToUpdate.Period = singleSesRequest.Period;
        singleSesRequestRepository?.Update(singleSesRequestToUpdate);
    }*/
}