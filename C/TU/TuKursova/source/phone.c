/*
 * phone.cpp
 *
 *  Created on: May 22, 2017
 *      Author: petar
 */

#include "phone.h"
#include <string.h>


void setModel(char name[20],Phone *phone)
{
	strcpy(phone->model, name);
}

void setNum(int num,Phone *phone)
{
	phone->num = num;
}
void setPrice(float price, Phone *phone)
{
	phone->price = price;
}
void setCount(int count, Phone *phone)
{
	if(count >= 0)
		phone->count = count;
}
void setPhone(int num,char model[20],float price,int count,Phone *phone)
{
	setNum(num,phone);
	setModel(model,phone);
	setPrice(price,phone);
	setCount(count,phone);
}

void printPhone(Phone* phone)
{
	printf("Number: %d\n Model: %s\n Price: %f\n Count: %d\n\n",phone->num,phone->model,phone->price,phone->count);
}
