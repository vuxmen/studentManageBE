using System;

namespace student_manager_api
{
    public enum Genders
    {
        Man = 1,
        Woman = 2
    }
    public record Student(string Id, DateTime CreatedDate, DateTime AdmissionDate, string Name, Genders Gender, string Img, string PhoneNumber, DateTime Birthday);
}
