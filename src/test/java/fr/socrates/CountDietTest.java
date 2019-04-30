package fr.socrates;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CountDietTest {

    @Test
    public void one_vegetarian_in_one_meal_should_return_one_vegetarian() {
        DietMeal dietMeal = new DietMeal();
        int countVegiMeal = dietMeal.countDiet();
        int countVegiMealExpectd = 1;
        assertThat(countVegiMeal).isEqualTo(countVegiMealExpectd);
    }
}
