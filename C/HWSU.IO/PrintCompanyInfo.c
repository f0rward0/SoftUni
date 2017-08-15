#include <stdio.h>
#include <stdlib.h>

int main()
{
    char Cname[256];
    char Caddress[256];
    char CPhone[256];
    char CFax[256];
    char CWeb[256];
    char MFname[256];
    char MLname[256];
    char Mage[256];
    char Mphone[256];
    printf("Enter company name: ");
    gets(Cname);
    printf("Enter company address: ");
    gets(Caddress);
    printf("Enter company Phone: ");
    gets(CPhone);
    printf("Enter company Fax: ");
    gets(CFax);
    printf("Enter company web site: ");
    gets(CWeb);
    printf("Enter manager first name: ");
    gets(MFname);
    printf("Enter manager last name: ");
    gets(MLname);
    printf("Enter manager age: ");
    gets(Mage);
    printf("Enter manager phone: ");
    gets(Mphone);



    printf("\n\n%s\nAddress: %s\nTel. %s\Fax: %s\nWeb page: %s\nManager %s %s(age: %s, tel. )",
           Cname,Caddress,CPhone,CFax,CWeb,MFname,MLname,Mage,Mphone);



    return 0;
}
