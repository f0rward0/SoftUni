/*
 * container.h
 *
 *  Created on: May 22, 2017
 *      Author: petar
 */

#ifndef APPLICATION_CONTAINER_H_
#define APPLICATION_CONTAINER_H_

#include "phone.h"
#include <stdlib.h>

typedef struct node
{
	struct node *next;
	Phone *data;

}Node;

/*
 * Inserting a new node at the head of the list
 */
Node* insertNode(Node *head, Phone *data);

/*
 * Removing a node from the head of the list
 */
void removeNode(Node *head);

#endif /* APPLICATION_CONTAINER_H_ */
