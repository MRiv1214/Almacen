namespace Almacen.Models.Dtos;

public record UserDto { public long? UserId { get; init; } public byte[]? Password { get; init; } public string? Name { get; init; } public string? LastName { get; init; } }
public record CreateUserDto { public required string Name { get; init; } public required string LastName { get; init; } public required byte[] Password { get; init; } }
public record EmployeeDto { public string? Payroll { get; init; } public long? CareerId { get; init; } public long? UserId { get; init; } public long? UserType { get; init; } }
public record CreateEmployeeDto { public required string Payroll { get; init; } public required long CareerId { get; init; } public required long UserId { get; init; } public required long UserType { get; init; } }