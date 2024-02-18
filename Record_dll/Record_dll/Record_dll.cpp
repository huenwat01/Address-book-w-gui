//Wat Wing Huen 21085591d
#include "Record.h"
#include <iostream> 
#include<iomanip>
#include<cmath>
#include <string> 
#include <regex>
using std::pow;
using namespace std;
using std::cout;
using std::string;
using std::endl;
using std::cin;
using std::setprecision;
using std::fixed;
using std::setw;
using std::right;
using std::regex_match;
using std::regex;

#include <fstream>
using std::ofstream;
using std::ifstream;
using std::ios;

extern "C"
{
	Record2* hptr;
	__declspec(dllexport) int dosomething()
	{
		return 1;
	}
	__declspec(dllexport) int countrecord()
	{
		int coun = 0;

		string n;

		ifstream inputRecord("Record.dat", ios::in);
		while (getline(inputRecord, n))
		{
			getline(inputRecord, n);
			getline(inputRecord, n);
			coun++;
		}
		inputRecord.close();
		return coun;
	}
	void linklist()
	{
		ifstream input("Record.dat", ios::in);
		int no = 0;
		int i = 0;
		string data;
		int pno;
		no = countrecord();
		Record2* fptr = 0, * tempptr = 0, * lastptr = 0, * headptr = 0;
		do
		{
			tempptr = new Record2;
			if (i == 0)
			{
				fptr = tempptr;
				lastptr = tempptr;
				headptr = tempptr;
				getline(input, data);
				tempptr->setname(data);
				getline(input, data);
				tempptr->setemail(data);
				input >> pno;
				tempptr->setpno(pno);
				i++;
			}
			else
			{
				tempptr->setpptr(lastptr);
				lastptr->setnptr(tempptr);
				getline(input, data);
				tempptr->setname(data);
				getline(input, data);
				tempptr->setemail(data);
				input >> pno;
				tempptr->setpno(pno);
				lastptr = tempptr;
				i++;
			}
		} while (i < no);
		hptr = fptr;
		input.close();
	}
	__declspec(dllexport) void initalize()
	{
		ofstream outputRecord("Record.dat", ios::out);
		outputRecord << "Lawrence Cheung" << endl;
		outputRecord << "enccl@eie.polyu.edu.hk" << endl;
		outputRecord << 27666131 << endl;
		outputRecord << "Helen Wong" << endl;
		outputRecord << "helenwog@yahoo.com.hk" << endl;
		outputRecord << 94665888 << endl;
		outputRecord << "Simon Sui" << endl;
		outputRecord << "ss123@gmail.com" << endl;
		outputRecord << 64441234 << endl;
		outputRecord << "Mary Ho" << endl;
		outputRecord << "ho.mary10@netvigator.com" << endl;
		outputRecord << 21111112 << endl;
		outputRecord.close();
		linklist();
	}


	__declspec(dllexport) void deleterecord(char const* dname)
	{
		string n1(dname);
		string name = "";
		string email = "";
		int pno = 0;
		ifstream input("Record.dat", ios::in);
		ofstream output("R2.dat", ios::out);
		
		/*for (; getline(input, name) && getline(input, name) && getline(input, email) && input >> pno;)
		{
			if (n1 != name)
			{
				output << name;
				output << endl;
				output << email;
				output << endl;
				output << pno;
				output << endl;
			}
		}*/
		if (getline(input, name) && getline(input, email) && input >> pno)
		{
			if(name!=n1)
			{
				output << name;
				output << endl;
				output << email;
				output << endl;
				output << pno;
				output << endl;
			}
			for (; getline(input, name)&& getline(input, name) && getline(input, email) && input >> pno;)
			{
				if (name != n1)
				{
					output << name;
					output << endl;
					output << email;
					output << endl;
					output << pno;
					output << endl;
				}
			}
		}		
		input.close();
		output.close();
		name = remove("Record.dat");
		name = rename("R2.dat", "Record.dat");
		linklist();
		/*string name2 = "";
		string email2 = "";
		int pno2 = 0;
		ifstream ip("R2.dat", ios::in);
		ofstream op("Record.dat", ios::out);
		if (getline(ip, name2) && getline(ip, email2) && ip >> pno2)
		{
			if (name != n1)
			{
				op << name2;
				op << endl;
				op << email2;
				op << endl;
				op << pno2;
				op << endl;
			}
			for (; getline(ip, name2) && getline(ip, name2) && getline(ip, email2) && ip >> pno2;)
			{
				if (name2 != n1)
				{
					op << name2;
					op << endl;
					op << email2;
					op << endl;
					op<< pno2;
					op << endl;
				}
			}
		}
		ip.close();
		op.close();*/
	}

	__declspec(dllexport) int checkname(char const* dname)
	{
		string n1(dname);
		regex n("[a-zA-Z0-9\\s]*");
		if (regex_match(n1, n))
		{
			return 0;
		}
		else
		{
			return 1;
		}
	}
	__declspec(dllexport) int checkemail(char const* demail)
	{
		string e1(demail);
		regex e("[a-zA-Z0-9]*@[a-zA-Z0-9]*");
		if (regex_match(e1, e))
		{
			return 0;
		}
		else
		{
			return 1;
		}
	}
	__declspec(dllexport) void writedata(char const* record)
	{
		string r(record);
		ofstream outputRecord("Record.dat", ios::app);
		outputRecord << r << endl;
		outputRecord.close();
	}
	
	
}