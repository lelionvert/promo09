package fr.socrates;

import java.time.LocalDateTime;

class SocratesEvent {
    private LocalDateTime startDateTime;
    private Meal meal;
    private int mealPrice;
    private int mealsNumber;

    SocratesEvent(LocalDateTime startDateTime, Meal meal) {
        this.startDateTime = startDateTime;
        this.meal = meal;
    }

    SocratesEvent(LocalDateTime startDateTime, int mealPrice, int mealsNumber) {
        this.startDateTime = startDateTime;
        this.mealPrice = mealPrice;
        this.mealsNumber = mealsNumber;
    }

    LocalDateTime getStartDateTime() {
        return startDateTime;
    }

    Meal getMeal() {
        return meal;
    }

    int getMealNumber() {
        return meal != null ? meal.getNumber() : mealsNumber;
    }

    int calculateTotalPrice(int mealsNumber) {
        return meal != null ? meal.calculateTotalPrice(mealsNumber) : mealsNumber * mealPrice;
    }
}
