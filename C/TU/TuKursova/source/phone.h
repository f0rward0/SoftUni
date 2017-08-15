/*
 * phone.h
 *
 *  Created on: May 22, 2017
 *      Author: petar
 */

#ifndef APPLICATION_PHONE_H_
#define APPLICATION_PHONE_H_

#include <stdio.h>

typedef struct phone
{
	int num;
	char model[20];
	float price;
	int count;
}Phone;

//functions that set arguments and do validations if needed
void setModel(char name[20],Phone *phone);
void setNum(int num,Phone *phone);
void setPrice(float price, Phone *phone);
void setCount(int count, Phone *phone);

/*
 * Setting fields of the phone structure(works like constructor)
 */
void setPhone(int num,char model[20],float price,int count,Phone *phone);

/*
 * Printing the information about the phone on the standard output
 */
void printPhone(Phone* phone);

#endif /* APPLICATION_PHONE_H_ */
