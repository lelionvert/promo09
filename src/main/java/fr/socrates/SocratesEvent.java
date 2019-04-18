package fr.socrates;

import java.time.LocalDateTime;

class SocratesEvent {
    private LocalDateTime startDateTime;
    private int mealPrice;
    private int mealsNumber;

    SocratesEvent(LocalDateTime startDateTime, int mealPrice, int mealsNumber) {
        this.startDateTime = startDateTime;
        this.mealPrice = mealPrice;
        this.mealsNumber = mealsNumber;
    }

    LocalDateTime getStartDateTime() {
        return startDateTime;
    }

    int getMealNumber() {
        return mealsNumber;
    }

    int calculateTotalPrice(int mealsNumber) {
        return mealsNumber * mealPrice;
    }
}
