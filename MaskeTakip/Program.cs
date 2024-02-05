using Business.Concrete;
using Entities.Concrete;


;
Person p1 = new Person()
{
	FirstName = "Fatih",
	LastName = "Mutlu",
	DateOfBirthYear = 1,
	NationalIdentity = 1
};

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(p1);
