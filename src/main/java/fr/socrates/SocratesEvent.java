package fr.socrates;

import java.time.LocalDateTime;

class SocratesEvent {
    private LocalDateTime dateTimeLimitFirstMealService;

    private int mealPrice;
    private int mealsNumber;

    SocratesEvent(LocalDateTime dateTimeLimitFirstMealService, int mealPrice, int mealsNumber) {
        this.dateTimeLimitFirstMealService = dateTimeLimitFirstMealService;
        this.mealPrice = mealPrice;
        this.mealsNumber = mealsNumber;
    }

    LocalDateTime getDateTimeLimitFirstMealService() {
        return dateTimeLimitFirstMealService;
    }

    int getMealNumber() {
        return mealsNumber;
    }

    int getMealPrice() {
        return mealPrice;
    }

    int calculateTotalPrice(int mealsNumber) {
        return mealsNumber * mealPrice;
    }
}
