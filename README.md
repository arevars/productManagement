# productManagement

1. first run migrations to create db and tables, (dotnet ef database update).
2. for authorization in Postman, set authorization to "Basic Auth", username/password is test/test, and use it for every authorized action
3. below is test data to post.
{
    "Name":"banana",
    "Price": 2.03,
    "Available":true,
    "Description":"Ecuador banana"
}

// TODO list
 - add unitOfWork repository design pattern
 - add jwt authorization/authentication
 - create users table and use it for users
 - create request/response models(DTOs(using Facade pattern)) to not show clients all fields from db but we need, to show corresponding messages instead of exceptions etc...
 - add services (additional abstraction layer) to not have any business logic in controller's actions
 - write unit tests
