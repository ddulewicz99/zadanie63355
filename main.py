
def kalkulator():
    print("\n--- Prosty kalkulator dwóch liczb ---")
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    operacja = input("Wybierz operację (+, -, *, /): ")

    if operacja == "+":
        wynik = a + b
    elif operacja == "-":
        wynik = a - b
    elif operacja == "*":
        wynik = a * b
    elif operacja == "/":
        if b != 0:
            wynik = a / b
        else:
            print("Błąd: dzielenie przez zero!")
            return
    else:
        print("Nieznana operacja.")
        return

    print("Wynik:", wynik)


def konwerter_temperatur():
    print("\n--- Konwerter temperatur Celsjusz ↔ Fahrenheit ---")
    kierunek = input("Wybierz kierunek konwersji (C/F): ").upper()
    temp = float(input("Podaj temperaturę: "))

    if kierunek == "C":
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik:.2f}°F")
    elif kierunek == "F":
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("Niepoprawny wybór.")


def srednia_ocen():
    print("\n--- Średnia ocen ucznia ---")
    n = int(input("Podaj liczbę ocen: "))
    suma = 0

    for i in range(n):
        ocena = float(input(f"Ocena #{i + 1}: "))
        suma += ocena

    srednia = suma / n
    print(f"Średnia: {srednia:.2f}")
    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


def main():
    while True:
        print("\n--- MENU ---")
        print("1. Kalkulator")
        print("2. Konwerter temperatur")
        print("3. Średnia ocen")
        print("0. Wyjście")
        wybor = input("Wybierz opcję: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor == "0":
            print("Zakończono program.")
            break
        else:
            print("Nieprawidłowy wybór.")


if __name__ == "__main__":
    main()
