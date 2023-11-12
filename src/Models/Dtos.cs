namespace Almacen.Models.Dtos;

public record UserDto
{
    public long? UserId { get; init; }
    public byte[]? Password { get; init; }
    public string? Name { get; init; }
    public string? LastName { get; init; }
}
public record CreateUserDto
{
    public required string Name { get; init; }
    public required string LastName { get; init; }
    public required byte[] Password { get; init; }
}
public record EmployeeDto
{
    public required string Payroll { get; init; }
    public required long CareerId { get; init; }
    public required long UserId { get; init; }
    public required long UserType { get; init; }
}
public record CareerDto
{
    public required string Name { get; init; }
    public required long CareerId { get; init; }
}
public record EmployeeGroupDto
{
    
    public required string Payroll { get; init; }
    public required long GroupId { get; init; }
    public required long EmployeeGroupId { get; init; }
}
public record EmployeeSubjectDto
{
    public required string Payroll { get; init; }
    public required long SubjectId { get; init; }
    public required long EmployeeSubjectId { get; init; }
}
public record StudentGroupDto
{
    public required long StudentGroupId { get; init; }
    public required long GroupId { get; init; }
    public required byte[] Register { get; init; }
}
public record StudentSubjectDto
{
    public required long StudentSubId { get; init; }
    public required long SubjectId { get; init; }
    public required byte[] Register { get; init; }
}
public record GroupDto
{
    public required long GroupId { get; init; }
    public required string Name { get; init; }
}
public record SubjectDto
{
    public required long SubjectId { get; init; }
    public required string Name { get; init; }
}
public record SubjectClaasroomDto
{
    public required long SubClassId { get; init; }
    public required long SubjectId { get; init; }
    public required long ClassroomId { get; init; }
}
public record ClassroomDto
{
    public required long ClassroomId { get; init; }
    public required byte[] Name { get; init; }
}
public record MaterialDto
{
    public required long MaterialId { get; init; }
    public required string Name { get; init; }
    public required string Desc { get; init; }
}
public record CampusDto
{
    public required long CampusId { get; init; }
    public required string Name { get; init; }
}
public record MaintenanceDto
{
    public required long MaintenanceId { get; init; }
    public required long MaterialId { get; init; }
    public required long CareerId { get; init; }
    public required string MaintType { get; init; }
    public required string Desc { get; init; }
    public required string SpareParts { get; init; }
    public required string Date { get; init; }
    public required string ScheduleDate { get; init; }
}
public record RequestDto
{
    public required long RequestId { get; init; }
    public required long CampusId { get; init; }
    public required long ClassroomId { get; init; }
    public required long CareerId { get; init; }
    public required long GroupId { get; init; }
    public required string Payroll { get; init; }
    public required long MaterialId { get; init; }
    public required string DepartureTime { get; init; }
    public required string DeliveryTime { get; init; }
    public required string Date { get; init; }
    public required byte[] MatAmount { get; init; }
    public required long AuthSignature { get; init; }
    public required byte[] ControlNum { get; init; }
}
public record MultipleSesRequestDto
{
    public required long MulSesRequestId { get; init; }
    public required long RequestId { get; init; }
    public required string Payroll { get; init; }
    public required string Period { get; init; }
    public required string InitialDate { get; init; }
    public required string EndDate { get; init; }
    public required string Days { get; init; }
}
public record SingleSesRequestDto
{
    public required long SinSesReqtId { get; init; }
    public required long RequestId { get; init; }
    public required string Payroll { get; init; }
    public required string Level { get; init; }
    public required string Period { get; init; }
}
public record StudentsRequestDto
{
    public required long StudentsRequestId { get; init; }
    public required byte[] Register { get; init; }
    public required long RequestId { get; init; }
}
