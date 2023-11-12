using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class MultipleSesRequestController
{
    private readonly IRepository<MultipleSesRequest>? mulSesRequestRepository;
    public MultipleSesRequestController(IRepository<MultipleSesRequest>? mulSesRequestRepository)
    {
        this.mulSesRequestRepository = mulSesRequestRepository;
    }
    public void CreateMulSesRequest(MultipleSesRequestDto mulSesRequestDto)
    {
        var mulSesRequest = new MultipleSesRequest
        {
            RequestId = mulSesRequestDto.RequestId,
            Payroll = mulSesRequestDto.Payroll,
            Period = mulSesRequestDto.Period,
            InitialDate = mulSesRequestDto.InitialDate,
            EndDate = mulSesRequestDto.EndDate,
            Days = mulSesRequestDto.Days,
        };
        mulSesRequestRepository?.Create(mulSesRequest);
    }
    public IEnumerable<MultipleSesRequest> GetAllMulSesRequests()
    {
        var mulSesRequests = mulSesRequestRepository?.GetAll();
        if (mulSesRequests == null)
        {
            return new List<MultipleSesRequest>();
        }
        return mulSesRequests.Select(mulSesRequest => new MultipleSesRequest
        {
            MulSesRequestId = mulSesRequest.MulSesRequestId,
            RequestId = mulSesRequest.RequestId,
            Payroll = mulSesRequest.Payroll,
            Period = mulSesRequest.Period,
            InitialDate = mulSesRequest.InitialDate,
            EndDate = mulSesRequest.EndDate,
            Days = mulSesRequest.Days,
        });
    }
    public MultipleSesRequest GetMulSesRequestById(long id)
    {
        var mulSesRequest = (mulSesRequestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new MultipleSesRequest
        {
            MulSesRequestId = mulSesRequest.MulSesRequestId,
            RequestId = mulSesRequest.RequestId,
            Payroll = mulSesRequest.Payroll,
            Period = mulSesRequest.Period,
            InitialDate = mulSesRequest.InitialDate,
            EndDate = mulSesRequest.EndDate,
            Days = mulSesRequest.Days,
        };
    }
    public void RemoveMulSesRequest(long id)
    {
        var mulSesRequest = (mulSesRequestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        mulSesRequestRepository?.Remove(mulSesRequest);
    }
    public void UpdateMulSesRequest(MultipleSesRequest mulSesRequest)
    {
        var mulSesRequestToUpdate = mulSesRequestRepository?.GetById(mulSesRequest.MulSesRequestId ?? throw new ArgumentException("Invalid id"))?? throw new ArgumentException("Invalid id");
        mulSesRequestToUpdate.RequestId = mulSesRequest.RequestId;
        mulSesRequestToUpdate.Payroll = mulSesRequest.Payroll;
        mulSesRequestToUpdate.Period = mulSesRequest.Period;
        mulSesRequestToUpdate.InitialDate = mulSesRequest.InitialDate;
        mulSesRequestToUpdate.EndDate = mulSesRequest.EndDate;
        mulSesRequestToUpdate.Days = mulSesRequest.Days;
        mulSesRequestRepository?.Update(mulSesRequestToUpdate);
    }
}
