/*This is an example of returning JSON users and mapping them onto a Javascript User Object*/
function User(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.fullName = firstName + ' ' + lastName;
    this.getUpperCaseFullName = function () {
        return this.firstName.toUpperCase() + ' ' + this.lastName.toUpperCase();
    }
}

/*This would be the JSON return from a REST call*/
var users = [
    { firstName: 'Michael', lastName: 'Jordan' },
    { firstName: 'Joe', lastName: 'Smith' }
];

users = $.map(users, function (user) {
    return new User(user.firstName, user.lastName);
});

$.each(users, function (index, user) {
    console.log(user.getUpperCaseFullName());
});

