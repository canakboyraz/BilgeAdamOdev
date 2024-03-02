
/*
  C# programlama dilinde "explicit" ve "implicit" ifadeler genellikle tür dönüşümleri (type conversions) bağlamında kullanılır.

Implicit(Kapalı): Bu tür dönüşümde, C# derleyicisi tür dönüşümünü otomatik olarak gerçekleştirir. İfadeler arasındaki dönüşüm açık bir şekilde belirtilmez, ancak türler uygunsa dönüşüm gerçekleşir. Örneğin, bir tam sayıyı ondalıklı bir sayıya dönüştürmek gibi.

*/

int a = 10;
double b = a; // Implicit conversion

/*
Explicit(Açık): Bu tür dönüşümde, dönüşümün açıkça belirtilmesi gerekir. Bu, bilgi kaybı riski olduğunda veya derleyici tarafından otomatik olarak gerçekleştirilemeyen durumlarda kullanışlı olabilir. Ayrıca, iki tür arasında açık bir ilişki olmadığında da gereklidir.
*/

double c = 10.5;
int d = (int)c; // Explicit conversion

/*
Açık tür dönüşümü, dönüşümün bilinçli olduğunu ve potansiyel olarak bilgi kaybı yaşanabileceğini belirtir. Bu nedenle, açık dönüşümleri kullanırken dikkatli olmak önemlidir ve gerektiğinde uygun hata işleme mekanizmalarını eklemek önemlidir.
*/