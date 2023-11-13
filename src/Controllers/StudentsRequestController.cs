using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class StudentsRequestController
{
    private readonly IRepository<StudentsRequest>? studentsRequestRepository;
    public StudentsRequestController(IRepository<StudentsRequest>? studentsRequestRepository)
    {
        this.studentsRequestRepository = studentsRequestRepository;
    }
    public long CreateStudentsRequest(StudentsRequestDto studentsRequestDto)
    {
        var studentsRequest = new StudentsRequest
        {
            Register = studentsRequestDto.Register,
            RequestId = studentsRequestDto.RequestId,
        };
        studentsRequestRepository?.Create(studentsRequest);
        return studentsRequest.StudentsRequestId;
    }
    public IEnumerable<StudentsRequest> GetAllStudentsRequests()
    {
        var studentsRequests = studentsRequestRepository?.GetAll();
        if (studentsRequests == null)
        {
            return new List<StudentsRequest>();
        }
        return studentsRequests.Select(studentsRequest => new StudentsRequest
        {
            StudentsRequestId = studentsRequest.StudentsRequestId,
            Register = studentsRequest.Register,
            RequestId = studentsRequest.RequestId,
        });
    }
    public StudentsRequest GetStudentsRequestById(long id)
    {
        var studentsRequest = (studentsRequestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new StudentsRequest
        {
            StudentsRequestId = studentsRequest.StudentsRequestId,
            Register = studentsRequest.Register,
            RequestId = studentsRequest.RequestId,
        };
    }
    public void RemoveStudentsRequest(long id)
    {
        var studentsRequest = (studentsRequestRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        studentsRequestRepository?.Remove(studentsRequest);
    }
    public void UpdateStudentsRequest(StudentsRequest studentsRequest)
    {
        var studentsRequestToUpdate = studentsRequestRepository?.GetById(studentsRequest.StudentsRequestId)?? throw new ArgumentException("Invalid id");
        studentsRequestToUpdate.Register = studentsRequest.Register;
        studentsRequestToUpdate.RequestId = studentsRequest.RequestId;
        studentsRequestRepository?.Update(studentsRequestToUpdate);
    }   
}