﻿int a = 3;
int b = 5;
int c = 6;
int d = 1;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine(max);