/*
 * FileIO.c
 *
 *  Created on: May 23, 2017
 *      Author: petar
 */

#include "FileIO.h"


Node* readFile(char* fileName,Node* head)
{
	long lSize;
	FILE *ptr;

	ptr = fopen(fileName,"rb");
	if (ptr==NULL) {fputs ("File error",stderr); exit (1);}

	// obtain file size:
	fseek(ptr, 0, SEEK_END);
	lSize = ftell(ptr);
	rewind(ptr);

	int i;
	for(i=0;i < lSize / sizeof(Phone);i++)
		head = insertNode(head, readPhone(ptr));

	fclose(ptr);
	return head;
}

void writeFile(char* fileName,Node* head)
{
	Node* tmp = head;
	FILE *ptr;

	ptr = fopen(fileName, "w+");
	if (ptr == NULL) {
		fputs("File error", stderr);
		exit(1);
	}

	while(NULL != tmp)
	{
		if(tmp->data->count == 0)			//removing phones with quantity of 0
		{
			tmp = tmp->next;
			continue;
		}
		fwrite(head->data,sizeof(Phone),1,ptr);
		tmp = tmp->next;
	}
	fclose(ptr);
}

Phone* readPhone(FILE* fp)
{
	Phone* phone= (Phone *)malloc(sizeof(Phone));
	fread(phone,sizeof(Phone),1,fp);

	return phone;
}
