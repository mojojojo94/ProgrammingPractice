// AdventureGame.cpp : Defines the entry point for the console application.
//

//#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int choice;

	cout << " Welcome to my adventure game!!\n\n";
	cout << " In this game we will experience a number of situations.\n";
	cout << " Each situation follows the same pattern for right now. \n";
	cout << " 1. A situation will be presented. \n";
	cout << " 2. You will be given some choices. \n";
	cout << " 3. you will be asked to make a choice. \n";
	cout << " 4. The result of your choice will be shown. \n";
	cout << " Later we will add things to this program such as score and other things. \n";

	cout << "\n\n You are in G hood and there is a dragon sleeping next to you.\n";
	cout << " What will you choose to do?\n";

	cout << " \n Here are your choices:\n";
	cout << " 1. You run to the next town.\n";
	cout << " 2. You hit the dragon in the foot.\n";
	cout << " 3. You go to sleep next to the dragon.\n";

	cout << "\n Your choice: ";
	cin >> choice;

	if (choice == 1) {
		cout << " \n Oh no! The next town was Lothric, you are now undead forever!!!\n";
	}
	else if (choice == 2) {
		cout << " Turns out that was the dragons weakness, you have defeated the dragon and obtained the dragon's foot.\n";
	}
	else if (choice == 3) {
		cout << " The dragon hates people that sleep next to him. You have been eaten by the dragon.\n";
	}
	else {
		cout << " You don't make the choices around here! I do!\n";
		cout << " Off with his head!\n";
		cout << " You are now dead\n";
		cout << " Game Over";
		return (0);
	}






    return 0;
}