var firstname;
var lastname;
var salary;
var permenantstaff;
function employee(fname, lname, salary, permenantstaff)
{
    this.firstname = fname;
    this.lastname - lname;
    this.salary = salary;
    this.permenantstaff = permenantstaff;
}
var empobj = new employee("John", "Stoke", 5000, false);
console.log('First Name:' + firstname + '\n' + "Last Name:" + lastname);
