using Homework.Collections.Controllers;


AuthorController authorController = new();

//authorController.GetByAge();


EmployeeController employeeController = new();

//employeeController.GetAllByBirthday();
//employeeController.GetEmployeesCount();


ProductController productController = new();
//productController.GetAll();

//productController.Search();

AccountController accountController = new();

var res = accountController.Login();

if (res)
{
    Console.WriteLine("Select one option: 1 - Show all products; 2 - Search the product");

   Option: string option = Console.ReadLine();

    int options;

    bool isCorrectOption = int.TryParse(option, out options);

    if (isCorrectOption)
    {
        switch (options)
        {
            case 1:

                productController.GetAll();
                break;
            case 2:
               productController.Search();
                break;
            default:
                Console.WriteLine("Option is not found, please select again");
                goto Option;
        }


    }
    else
    {
        Console.WriteLine("Option format is wrong! Please choose the right number!");
        goto Option;
    }
    

}