/*Doseg varijabli - blok doseg*/
#include <stdio.h>

main() {
	int a = 1;  //Zakomentirati
	{
		int a = 2;
		printf("%d ", a);
	}
	printf("%d ", a);

	return 0;
}
