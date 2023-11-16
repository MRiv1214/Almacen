using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class RequestController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<Request>? requestRepository;
    public RequestController(IRepository<Request>? requestRepository)
    {
        this.requestRepository = requestRepository;
    }
    public long CreateRequest(RequestDto requestDto)
    {
        var request = new Request
        {
            CampusId = requestDto.CampusId,
            ClassroomId = requestDto.ClassroomId,
            CareerId = requestDto.CareerId,
            GroupId = requestDto.GroupId,
            Payroll = requestDto.Payroll,
            MaterialId = requestDto.MaterialId,
            DepartureTime = requestDto.DepartureTime,
            DeliveryTime = requestDto.DeliveryTime,
            Date = requestDto.Date,
            MatAmount = requestDto.MatAmount,
            AuthSignature = requestDto.AuthSignature,
            ControlNum = requestDto.ControlNum,
        };
        requestRepository?.Create(request);
        return request.RequestId;
    }
    public IEnumerable<Request> GetAllRequests()
    {
        var requests = requestRepository?.GetAll();
        if (requests == null)
        {
            return new List<Request>();
        }
        return requests.Select(request => new Request
        {
            RequestId = request.RequestId,
            CampusId = request.CampusId,
            ClassroomId = request.ClassroomId,
            CareerId = request.CareerId,
            GroupId = request.GroupId,
            Payroll = request.Payroll,
            MaterialId = request.MaterialId,
            DepartureTime = request.DepartureTime,
            DeliveryTime = request.DeliveryTime,
            Date = request.Date,
            MatAmount = request.MatAmount,
            AuthSignature = request.AuthSignature,
            ControlNum = request.ControlNum,
        });
    }
    public Request GetRequestById(long id)
    {
        var request = (requestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Request
        {
            RequestId = request.RequestId,
            CampusId = request.CampusId,
            ClassroomId = request.ClassroomId,
            CareerId = request.CareerId,
            GroupId = request.GroupId,
            Payroll = request.Payroll,
            MaterialId = request.MaterialId,
            DepartureTime = request.DepartureTime,
            DeliveryTime = request.DeliveryTime,
            Date = request.Date,
            MatAmount = request.MatAmount,
            AuthSignature = request.AuthSignature,
            ControlNum = request.ControlNum,
        };
    }
    public void RemoveRequest(long id)
    {
        var request = (requestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        requestRepository?.Remove(request);
    }
    public void UpdateRequest(Request request)
    {
        var requestToUpdate = requestRepository?.GetById(request.RequestId)?? throw new ArgumentException("Invalid id");
        requestToUpdate.CampusId = request.CampusId;
        requestToUpdate.ClassroomId = request.ClassroomId;
        requestToUpdate.CareerId = request.CareerId;
        requestToUpdate.GroupId = request.GroupId;
        requestToUpdate.Payroll = request.Payroll;
        requestToUpdate.MaterialId = request.MaterialId;
        requestToUpdate.DepartureTime = request.DepartureTime;
        requestToUpdate.DeliveryTime = request.DeliveryTime;
        requestToUpdate.Date = request.Date;
        requestToUpdate.MatAmount = request.MatAmount;
        requestToUpdate.AuthSignature = request.AuthSignature;
        requestToUpdate.ControlNum = request.ControlNum;
        requestRepository?.Update(requestToUpdate);
    }
    */
}
