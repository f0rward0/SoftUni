#include <visual_2013.h>
#include <stdio.h>
#include <stdlib.h>

#define LENGHT 20


void printArray(int arr[], int lenght);
void fillArray(int arr[]);
int findMinOfFive(int arr[], int index);
void fillWithoutMissing(int arr1[], int arr2[], int arr3[]);
void bubble_srt(int arr[], int lenght);
void fillWithSortedArrays(int arr2[], int arr3[], int arr4[]);

int main()
{
	int arr1[LENGHT];
	int arr2[LENGHT / 5];
	int arr3[LENGHT - LENGHT / 5];
	int arr4[LENGHT];
	int j;
	int i;
	int cnt = 0;


	int option;
	do{
		printf("         CHOSE OPTION         \n\n");
		printf("  1:Fill array automatically \n");
		printf("  2:Fill array manually \n");
		printf("  3:Do the magic \n");
		printf("  4:Print the arrays \n");
		printf("  5:Exit \n");
		scanf("%d", &option);

		switch (option)
		{
		case 1:
			fillArray(arr1);
			printf("Array is filled\n");
			system("PAUSE");
			break;
		case 2:
			for (j = 0; j < LENGHT; j++)
			{
				scanf("%d", &arr1[j]);
			}
			printf("Array is filled\n");
			system("PAUSE");
			break;
		case 3:
			for (i = 0; i < LENGHT; i += 5)
			{
				arr2[cnt] = findMinOfFive(arr1, i);
				cnt++;
			}

			fillWithoutMissing(arr1, arr2, arr3);
			bubble_srt(arr2, LENGHT / 5);
			bubble_srt(arr3, LENGHT - LENGHT / 5);
			fillWithSortedArrays(arr2, arr3, arr4);
			printf("The magic happend\n");
			system("PAUSE");
			break;
		case 4:
			printf("ARRAY 1\n");
			printArray(arr1, LENGHT);
			printf("ARRAY 2\n");
			printArray(arr2, LENGHT / 5);
			printf("ARRAY 3\n");
			printArray(arr3, LENGHT - LENGHT / 5);
			printf("ARRAY 4\n");
			printArray(arr4, LENGHT);
			system("PAUSE");
			break;
		}
		system("cls");
	} while (option != 5);



	printf("\n");
	system("PAUSE");
	return 0;
}


void printArray(int arr[], int lenght)
{
	int i;
	for (i = 0; i < lenght; i++)
	{
		if (i == lenght - 1)
			printf("%d", arr[i]);
		else
			printf("%d, ", arr[i]);

	}
	printf("\n");

}

void fillArray(int arr[])
{
	int i;
	for (i = 0; i < LENGHT; i++)
	{
		arr[i] = i;
	}


}

int findMinOfFive(int arr[], int index)
{
	int i;
	int min = arr[index];
	for (i = index; i < index + 4; i++)
	{
		if (arr[i] > arr[i + 1])
		{
			min = arr[i + 1];
		}
	}

	return min;
}

void fillWithoutMissing(int arr1[], int arr2[], int arr3[])
{
	int i;
	int cntArr2 = 0;
	int cntArr3 = 0;

	for (i = 0; i < LENGHT; i++)
	{
		if (arr1[i] != arr2[cntArr2])
		{
			arr3[cntArr3] = arr1[i];
			cntArr3++;
		}
		else
		{
			cntArr2++;
		}
	}
}

void bubble_srt(int arr[], int lenght)
{
	int i, j;
	int temp;

	for (i = 0; i < lenght; i++)         // Make a pass through the array for each element
	{
		for (j = 1; j < (lenght - i); j++) // Go through the array beginning to end
		{
			if (arr[j - 1] > arr[j])       // If the the first number is greater, swap it 
			{
				temp = arr[j - 1];
				arr[j - 1] = arr[j];
				arr[j] = temp;
			}
		}
	}
}

void fillWithSortedArrays(int arr2[], int arr3[], int arr4[])
{
	int i;
	for (i = 0; i < LENGHT; i++)
	{
		if (i < LENGHT / 5)
		{
			arr4[i] = arr2[i];
		}
		else
		{
			arr4[i] = arr3[i - LENGHT / 5];
		}
	}

}