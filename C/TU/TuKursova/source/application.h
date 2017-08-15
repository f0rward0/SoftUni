/*
 * application.h
 *
 *  Created on: May 22, 2017
 *      Author: petar
 */

#ifndef APPLICATION_APPLICATION_H_
#define APPLICATION_APPLICATION_H_

#include "container.h"

/*
 * Main application logic in this function
 */
void run();

/*
 * Allocates and creates an object of type phone and returns
 * pointer to the object.
 */
Phone* addPhone(int num,char model[20],float price,int count);

/*
 * Changing the quantity of a phone model.
 * @arg num - represent the unique phone code(used for searching)
 * @arg quantity - a number which will be aded to the phones quantity
 * 			(add negative number to substract from quantity )
 */
void changeQuantity(int num,int quantity,Node* head);

/*
 * Calculates the average price of the phones in the list
 * and prints the phones which price is greater
 */
void printAboveAveragePrice(Node *head);

/*
 * Performing a search by unique phone code(num)
 * and prints the phone if found.
 */
void printPhoneFromNum(int num, Node* head);

/*
 * Checking if there is already a phone with
 * specific unique code(num) in the list
 * @returns 1 if found and 0 if not found.
 */
int checkPhoneFromNum(int num, Node* head);
/*
 * Deallocates the memory used for the list
 */
void freeList(Node* head);

#endif /* APPLICATION_APPLICATION_H_ */
