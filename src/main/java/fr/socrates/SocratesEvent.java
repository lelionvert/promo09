package fr.socrates;

import java.time.LocalDateTime;

class SocratesEvent {
    private LocalDateTime dateTimeLimitFirstMealService;
    private LocalDateTime dateTimeStartLastMealService;
    private int mealPrice;
    private int defaultMealsNumber;

    SocratesEvent(LocalDateTime dateTimeLimitFirstMealService, LocalDateTime dateTimeStartLastMealService, int mealPrice, int defaultMealsNumber) {
        this.dateTimeStartLastMealService = dateTimeStartLastMealService;
        this.dateTimeLimitFirstMealService = dateTimeLimitFirstMealService;
        this.mealPrice = mealPrice;
        this.defaultMealsNumber = defaultMealsNumber;
    }

    LocalDateTime getDateTimeLimitFirstMealService() {
        return dateTimeLimitFirstMealService;
    }

    int getMealNumber() {
        return defaultMealsNumber;
    }

    int getMealPrice() {
        return mealPrice;
    }

    int calculateTotalPrice(int mealsNumber) {
        return mealsNumber * mealPrice;
    }

    LocalDateTime getDateTimeStartLastMealService() {
        return dateTimeStartLastMealService;
    }
}
