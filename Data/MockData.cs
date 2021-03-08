using System;
using System.Collections.Generic;
using System.Linq;

namespace student_manager_api
{
    public static class MockData
    {
        public static IEnumerable<Student> GenerateData()
        {
            var dataForOneUser = new Student[] {
                new(
                  Id: "1",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn A",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "2",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn B",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "3",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn C",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "4",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn D",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "5",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn E",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "6",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn F",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "7",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn A",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "8",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn B",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "9",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn C",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "10",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn D",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "11",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn E",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "12",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn F",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "13",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn E",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
                new(
                  Id: "14",
                  CreatedDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  AdmissionDate: DateTime.Parse("2021-01-14T05:57:32.319456Z"),
                  Name: "Nguyễn Văn F",
                  Gender: Genders.Man,
                  Img: "default.png",
                  PhoneNumber: "0123456789",
                  Birthday: DateTime.Parse("2021-01-14T05:57:32.319456Z")
                ),
            };

            return dataForOneUser;

            // var users = new string[] { "admin" };

            // return users.SelectMany(u => dataForOneUser.Select(t => t with { User = u, Id = Guid.NewGuid().ToString() }));
        }
    }
}
