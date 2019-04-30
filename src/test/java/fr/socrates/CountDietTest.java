package fr.socrates;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CountDietTest {

    @Test
    public void one_vegetarian_in_one_meal_should_return_one_vegetarian() {
        CoverCounter coverCounter = new CoverCounter();

        int vegetarianCoverCount = coverCounter.countVegetarianCover();
        int vegetarianMealExpectedCount = 1;

        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }
}
