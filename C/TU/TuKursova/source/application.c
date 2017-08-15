/*
 * application.c
 *
 *  Created on: May 22, 2017
 *      Author: petar
 */
#include "FileIO.h"
#include "application.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

void run()
{
	Node* head = NULL;
	int option;
	while (1) {

		printf("\t\t MENU\n\n");
		printf("1: Add new phone\n");
		printf("2: Change phone quantity\n");
		printf("3: Print phones above average price\n");
		printf("4: Print phone by number\n");
		printf("5: exit\n");
		printf("6: Read from file\n");
		printf("7: Write to file\n");
		scanf("%d", &option);

		if (option < 1 || option > 7) {
			printf("Error: Pick a valid option.");
			//Add a pause here so the message can be seen
			continue;
		}


		int num = 0, count = 0;
		int quantity = 0;
		char model[20] = "";
		float price;
		char fileName[20] = "";

		switch (option) {
		case 1:
			printf("Enter: Number,price and count separated by space\n");
			scanf("%d %f %d", &num, &price, &count);
			printf("Enter a model\n");
			scanf("%s",model);
			if(!checkPhoneFromNum(num,head))
				head = insertNode(head, addPhone(num, model, price, count));
			else
				printf("phone with that number already exist\n");
			break;

		case 2:
			printf("Enter phone number.");
			scanf("%d", &num);
			printf("Enter phone quantity (negative to reduce).");
			scanf("%d", &quantity);
			changeQuantity(num, quantity, head);
			break;

		case 3:
			printAboveAveragePrice(head);
			break;

		case 4:
			printf("Enter phone number.");
			scanf("%d", &num);
			printPhoneFromNum(num, head);
			break;

		case 5:
			freeList(head);				//clearing our mess and exiting the program
			return;

		case 6:
			printf("Enter file name (.bin).");
			scanf("%s",fileName);
			head = readFile(fileName,head);
			break;

		case 7:
			printf("Enter file name (.bin).");
			scanf("%s", fileName);
			writeFile(fileName, head);
			break;

		}
	}


}
Phone* addPhone(int num,char model[20],float price,int count)
{
	Phone* phone= (Phone *)malloc(sizeof(Phone));
	setPhone(num, model, price, count, phone);
	return phone;
}

void changeQuantity(int num,int quantity,Node* head)
{
	Node* temp = head;
	while(temp != NULL)
	{
		if(num == temp->data->num)
		{
			if(temp->data->count + quantity < 0)
			{
				printf("Error: Not enough phones");
				return;
			}
			else
			{
				temp->data->count += quantity;
				return;
			}
		}
		temp = temp->next;
	}
	printf("No phone with number %d", num);
}

void printAboveAveragePrice(Node *head)
{
	double price = 0.0;
	int count = 0;
	Node* temp = head;
	while (temp != NULL)
	{
		price += temp->data->price;
		count++;
		temp = temp->next;
	}
	price = price / count;

	temp = head;
	while (temp != NULL)
	{
		if(temp->data->price >= price)
		{
			printPhone(temp->data);
		}
		temp = temp->next;
	}
}

void printPhoneFromNum(int num, Node* head)
{
	Node* temp = head;
	while(temp != NULL)
	{
		if(temp->data->num == num)
		{
			printPhone(temp->data);
			return;
		}
		temp = temp->next;
	}
}

int checkPhoneFromNum(int num, Node* head)
{
	Node* temp = head;
	while(temp != NULL)
	{
		if(temp->data->num == num)
		{
			return 1;
		}
		temp = temp->next;
	}
	return 0;
}

void freeList(Node* head)
{
	Node *followPtr = head;
	while (head != NULL) {
		followPtr = head;
		head = head->next;
		free(followPtr->data);
		free(followPtr);
	}
}
