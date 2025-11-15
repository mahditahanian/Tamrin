// See https://aka.ms/new-console-template for more information
using Tamrin.T1;
using Tamrin.T2;
using Tamrin.T2.Enum;
using Tamrin.T2.Extention;
using Tamrin.T2.Pred;
using Tamrin.T2.Spec;

Console.WriteLine("Hello, World!");






//تمرین اول 
#region تمرین اول

//Parallel.For(0, 4, i =>
//{
//    int threadId = Thread.CurrentThread.ManagedThreadId;

//    var inst1 = FactorManager.Instance;
//    var inst2 = FactorManager.Instance;
//    var inst3 = FactorManager.Instance;

//    Console.WriteLine($"[Thread {threadId}] HashCodes: {inst1.GetHashCode()}, {inst2.GetHashCode()}, {inst3.GetHashCode()}");
//});

#endregion



//تمرین دوم 

#region تمرین دوم

var nameSpec = new NameContainsSpecification("Ali");
var ageSpec = new AgeGreaterThanSpecification(20);
var adminSpec = new IsAdminSpecification(); 

var rest = new List<(LogicalOperator, ISpecification<User>)>
{
    (LogicalOperator.And, ageSpec),
    (LogicalOperator.Or, adminSpec),
};
//نام و سن یا ادمین بودن چک شود
var finalSpec = new Specification<User>(nameSpec, rest);


var filteredUsers = new List<User>();

var users = new List<User>
{
    new User { Name = "ali", Age = 25, IsAdmin = true },
    new User { Name = "Sara", Age = 30, IsAdmin = true },
    new User { Name = "Reza", Age = 17, IsAdmin = false },
    new User { Name = "Mina", Age = 40, IsAdmin = true },
};

Console.WriteLine("filtered Users By Spec");
foreach (var user in users)
{
    if (finalSpec.IsSatisfiedBy(user))
    {
        filteredUsers.Add(user);
        Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, IsAdmin: {user.IsAdmin}");
    }
}


var filteredUsersLinq = users
    .Where(u => finalSpec.IsSatisfiedBy(u))
    .ToList();

string name = "ali";
int minAge = 20;
bool onlyAdmin = true;
Console.WriteLine("filtered Users By Extention");
var filteredUsersByExtention = users
    .WhereIf(!string.IsNullOrEmpty(name), u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
    .WhereIf(minAge > 0, u => u.Age > minAge)
    .WhereIf(onlyAdmin, u => u.IsAdmin)
    .ToList();
foreach (var u in filteredUsersByExtention)
{
    Console.WriteLine($"Name: {u.Name}, Age: {u.Age}, IsAdmin: {u.IsAdmin}");
}
#endregion









