#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct Flat
{
	char region[20];
	char adress[20];
	int floor;
	int size;
	int cost;
	char type[20]; 
	int rooms;
} Flat;

typedef struct Customer
{
	char * AvailableRegions[20];
	char * ExceptRegions[20];
	char * AvailableAdresses[20];
	char * ExceptAdresses[20];
	int * AvailableFloor;
	int * ExceptFloor;
	int MinSize;
	int MaxSize;
	int * AvailableRooms;
	int * ExceptRooms;
	int MinSum;
	int MaxSum;
	char name[20];
	char surname[20];
	char contact[20];
	int ID;
} Customer;

typedef struct Owner
{
	char name[20];
	char surname[20];
	char contact[20];
	Flat flat;
	int ID;
} Owner;

typedef struct _Node {
	void* value;
	struct _Node* next;
	struct _Node* prev;
} Node;
typedef struct LinkedList {
	size_t size;
	Node* head;
	Node* tail;
} LinkedList;

