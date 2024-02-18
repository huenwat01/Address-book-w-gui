#include "Record.h"
#include <iostream> 
#include<iomanip>
#include<cmath>
using std::pow;
using std::string;

using std::cout;
using std::endl;
using std::cin;
using std::setprecision;
using std::fixed;
using std::setw;
using std::right;

Record2::Record2()
{
	string name;
	string email;
	int pno;
	nptr=0;
	pptr=0;

}

void Record2::setname(string n)
{
	name = n;
}

void Record2::setemail(string e)
{
	email = e;
}
void Record2::setpno(int p)
{
	pno = p;
}
void Record2::setnptr(Record2*ptr)
{
	nptr = ptr;
}
void Record2::setpptr(Record2*ptr)
{
	pptr = ptr;
}

string Record2::getname()
{
	return name;
}
string Record2 ::getemail()
{
	return email;
}
int Record2::getpno()
{
	return pno;
}
Record2* Record2::getnptr()
{
	return nptr;
}
Record2* Record2::getpptr()
{
	return pptr;
}
