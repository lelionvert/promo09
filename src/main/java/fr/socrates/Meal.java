package fr.socrates;

class Meal {
    private int price;
    private int number;

    Meal(int price, int number) {
        this.price = price;
        this.number = number;
    }

    int getTotalPrice(int number) {
        return number * this.price;
    }

    int getNumber() {
        return number;
    }
}
