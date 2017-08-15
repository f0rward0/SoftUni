/*
 * container.c
 *
 *  Created on: May 22, 2017
 *      Author: petar
 */

#include "container.h"

Node* insertNode(Node *node, Phone *data)
{
	Node* tempNode = (Node*)malloc(sizeof(Node));
	if(tempNode == NULL)
	{
		exit(0);			//not enough memory
	}

	tempNode->data = data;
	tempNode->next = node;
	node = tempNode;

	return node;
}

void removeNode(Node* head) {
	Node* temp = (Node*) malloc(sizeof (Node));
    if (temp == NULL) {
        exit(EXIT_FAILURE); // no memory available
    }
    temp = head->next;
    head->next = head->next->next;
    free(temp);
}


