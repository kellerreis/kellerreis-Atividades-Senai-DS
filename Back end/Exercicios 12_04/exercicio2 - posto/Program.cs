//Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
//da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
//sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.



float liter_gasoline_price = 5.3f;
float liter_alcohol_price = 4.9f;



Console.Write($"Insira o total de Litros vendidos: ");
float litersSold = float.Parse(Console.ReadLine());

Console.Write($"Insira o tipo do combustível usado (A - álcool, G - gasolina): ");
char fuelType = char.Parse(Console.ReadLine().ToUpper());

float totalPrice = TotalPrice(litersSold, fuelType, liter_gasoline_price, liter_alcohol_price);
string fuelTypeName = fuelType == 'A' ? "álcool" : "gasolina";

Console.WriteLine(); // Pula linha

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
Preço total: R$ {totalPrice.ToString("F2")}
Litros do combustível: {litersSold}
Tipo do combustível: {fuelTypeName}
");
Console.ResetColor();


static float TotalPrice(float liters, char fuelType, float gasolineLiterPrice, float alcoholLiterPrice)
{
    float totalPrice = 0;
    float discount = 0; // Var que guarda o valor do desconto

    // Se for álcool
    switch (fuelType)
    {
        case 'A': // R$ 4,90
            totalPrice = (liters * alcoholLiterPrice); // Calcula o valor total

            if (liters <= 20)
            {
                discount = totalPrice * 0.03f; // Pega 3% do valor total
            }
            else
            {
                discount = totalPrice * 0.05f; // Pega 5% do valor total
            }
            totalPrice = totalPrice - discount; // Subtrai o desconto do valor total
            break;

        case 'G': // R$ 5,30
            totalPrice = (liters * gasolineLiterPrice); // Calcula o valor total

            if (liters <= 20)
            {
                discount = totalPrice * 0.04f; // Pega 4% do valor total
            }
            else
            {
                discount = totalPrice * 0.06f; // Pega 6% do valor total
            }
            totalPrice = totalPrice - discount; // Subtrai o desconto do valor total
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Insira os valores corretos do tipo de gasolina!!");
            Console.ResetColor();
            return 0;
            break;
    }

    return totalPrice;
}