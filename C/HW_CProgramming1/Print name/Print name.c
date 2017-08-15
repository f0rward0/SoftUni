#include <visual_2013.h>
#include <stdio.h>
#include <stdlib.h>



int main(int argc, char** argv) 
{


	//char* MFname, MLname, Mage, Mphone;
	printf("\nCompany name: ");
	char* companyName= gets(companyName);
	printf("\nCompany address: ");
	char* CompanyAddress=gets(CompanyAddress);
	printf("\nPhone number: ");
	char* CompanyNumber=gets(CompanyNumber);
	printf("\nFax number: ");
	char* CFaxNumber=gets(CFaxNumber);
	printf("\nWeb site: ");
	char* CwebSite=gets(CwebSite);
	printf("\nManager first name: ");
	char* MFname=gets(MFname);
	printf("\nManager last name: ");
	char* MLname=gets(MLname);
	printf("\nManager age: ");
	char* Mage=gets(Mage);
	printf("\nManager phone: ");
	char* Mphone=gets(Mphone);


	printf("%s\nAddress: %s\nTel: %s\nFax: %s\n",
		companyName, CompanyAddress, CompanyNumber, CFaxNumber);

	printf("Manager: %s %s (age %s,tel: %s)",
		MFname, MLname, Mage, Mphone);

	system("pause");
	return (0);
}