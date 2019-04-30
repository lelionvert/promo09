package fr.socrates;

import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class CountDietTest {

    private Cover pescatarian = new Cover(DietType.PESCATARIAN);
    private Cover vegetarian = new Cover(DietType.VEGETARIAN);

    @Test
    public void one_vegetarian_in_one_meal_should_return_one_vegetarian() {
        CoverCounter coverCounter = new CoverCounter();
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);

        long vegetarianCoverCount = coverCounter.countVegetarianCover(covers);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_one_vegetarian() {
        CoverCounter coverCounter = new CoverCounter();
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        covers.add(pescatarian);

        long vegetarianCoverCount = coverCounter.countVegetarianCover(covers);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void two_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_2() {
        CoverCounter coverCounter = new CoverCounter();
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        covers.add(vegetarian);
        covers.add(pescatarian);

        long vegetarianCoverCount = coverCounter.countVegetarianCover(covers);

        long vegetarianMealExpectedCount = 2;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_pescatarian_in_one_meal_should_return_one() {
        CoverCounter coverCounter = new CoverCounter();
        List<Cover> covers = new ArrayList<>();
        covers.add(pescatarian);
        long pescatarianCoverCount = coverCounter.countPescatarian(covers);

        long pescatarianCoverCountExpected = 1;
        assertThat(pescatarianCoverCount).isEqualTo(pescatarianCoverCountExpected);
    }

    @Test
    public void two_pescatarian_and_one_vegetarian_in_one_meal_should_return_2() {
        CoverCounter coverCounter = new CoverCounter();
        List<Cover> covers = new ArrayList<>();
        covers.add(pescatarian);
        covers.add(pescatarian);
        covers.add(vegetarian);

        long pescatarianCoverCount = coverCounter.countPescatarian(covers);
        long pescatarianCoverCountExpected = 2;
        assertThat(pescatarianCoverCount).isEqualTo(pescatarianCoverCountExpected);
    }
}
