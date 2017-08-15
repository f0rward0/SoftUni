/*
 * FileIO.h
 *
 *  Created on: May 23, 2017
 *      Author: petar
 */

#ifndef APPLICATION_FILEIO_H_
#define APPLICATION_FILEIO_H_

#include "application.h"

/*
 * Reading binary file with phones
 * and adding phone nodes to the list
 */
Node* readFile(char* fileName,Node* head);

/*
 * Writing the phone data on binary file
 */
void writeFile(char* fileName,Node* head);

/*
 * Allocates data for one phone
 * and fills it with the information
 * from the binary file.
 * @returns pointer to a Phone object in the heap
 */
Phone* readPhone(FILE* fp);


#endif /* APPLICATION_FILEIO_H_ */
