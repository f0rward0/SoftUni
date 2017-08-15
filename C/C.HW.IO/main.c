#include <stdio.h>
#include <stdlib.h>

int main()
{
    /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * File:   PrintCompanyInformation.c
 * Author: Velkata
 *
 * Created on 21 Октомври 2015, 14:15
 */

#include <stdio.h>
#include <stdlib.h>

/*
 *
 */
int main(int argc, char** argv) {
    char *companyName,*CompanyAddress,*CompanyNumber,
            *CFaxNumber,*CwebSite;

    char *MFname,*MLname,*Mage,*Mphone;
    printf("\nCompany name: ");
    scanf("%s",companyName);
    printf("\nCompany address: ");
    scanf("%s",CompanyAddress);
    printf("\nPhone number: ");
    scanf("%s",CompanyNumber);
    printf("\nFax number: ");
    scanf("%s",CFaxNumber);
    printf("\nWeb site: ");
    scanf("%s",CwebSite);
    printf("\nManager first name: ");
    scanf("%s",MFname);
    printf("\nManager last name: ");
    scanf("%s",MLname);
    printf("\nManager age: ");
    scanf("%s",Mage);
    printf("\nManager phone: ");
    scanf("%s",Mphone);


    printf("%s\nAddress: %s\nTel: %s\nFax: %s\n",
            companyName,CompanyAddress,CompanyNumber,CFaxNumber);

    printf("Manager: %s %s (age %s,tel: %s)",
            MFname,MLname,Mage,Mphone);

    return (EXIT_SUCCESS);

}
