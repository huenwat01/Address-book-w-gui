#pragma once
#include <iostream> 
#include<iomanip>
#include<cmath>
using std::string;
using std::pow;
using std::cout;
using std::endl;
using std::cin;
using std::setprecision;
using std::fixed;
using std::setw;
using std::right;
class Record2
{
public:
	Record2();
	void setname(string);
	void setemail(string);
	void setpno(int);// set phone number
	void setnptr(Record2*);
	void setpptr(Record2*);//set previous ptr

	string getname();
	string getemail();
	int getpno();
	Record2* getnptr();
	Record2* getpptr();
	Record2* fprt;



private:
	string name;
	string email;
	int pno;//phone number;
	Record2* nptr;// next ptr;
	Record2* pptr;// previous ptr


};