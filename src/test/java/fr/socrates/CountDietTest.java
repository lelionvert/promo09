package fr.socrates;

import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class CountDietTest {

    private Cover pescatarian = new Cover(DietType.PESCATARIAN);
    private Cover vegan = new Cover(DietType.VEGAN);
    private Cover vegetarian = new Cover(DietType.VEGETARIAN);
    private Cover omnivorous = new Cover(DietType.OMNIVOROUS);

    @Test
    public void one_vegetarian_in_one_meal_should_return_one_vegetarian() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        CoverCounter coverCounter = new CoverCounter(covers);

        long vegetarianCoverCount = coverCounter.countForDiet(DietType.VEGETARIAN);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_one_vegetarian() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        covers.add(pescatarian);
        CoverCounter coverCounter = new CoverCounter(covers);

        long vegetarianCoverCount = coverCounter.countForDiet(DietType.VEGETARIAN);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void two_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_2() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        covers.add(vegetarian);
        covers.add(pescatarian);
        CoverCounter coverCounter = new CoverCounter(covers);

        long vegetarianCoverCount = coverCounter.countForDiet(DietType.VEGETARIAN);

        long vegetarianMealExpectedCount = 2;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_pescatarian_in_one_meal_should_return_one() {
        List<Cover> covers = new ArrayList<>();
        covers.add(pescatarian);
        CoverCounter coverCounter = new CoverCounter(covers);

        long pescatarianCoverCount = coverCounter.countForDiet(DietType.PESCATARIAN);

        long pescatarianCoverCountExpected = 1;
        assertThat(pescatarianCoverCount).isEqualTo(pescatarianCoverCountExpected);
    }

    @Test
    public void two_pescatarian_and_one_vegetarian_in_one_meal_should_return_2() {
        List<Cover> covers = new ArrayList<>();
        covers.add(pescatarian);
        covers.add(pescatarian);
        covers.add(vegetarian);
        CoverCounter coverCounter = new CoverCounter(covers);

        long pescatarianCoverCount = coverCounter.countForDiet(DietType.PESCATARIAN);

        long pescatarianCoverCountExpected = 2;
        assertThat(pescatarianCoverCount).isEqualTo(pescatarianCoverCountExpected);
    }

    @Test
    public void one_vegan_in_one_meal_should_return_one() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegan);
        CoverCounter coverCounter = new CoverCounter(covers);

        long veganCoverCount = coverCounter.countForDiet(DietType.VEGAN);

        long veganCoverCountExpected = 1;
        assertThat(veganCoverCount).isEqualTo(veganCoverCountExpected);
    }

    @Test
    public void two_vegan_and_2_pescatarian_in_one_meal_should_return_2() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegan);
        covers.add(vegan);
        covers.add(pescatarian);
        covers.add(pescatarian);
        CoverCounter coverCounter = new CoverCounter(covers);

        long veganCoverCount = coverCounter.countForDiet(DietType.VEGAN);

        long veganCoverCountExpected = 2;
        assertThat(veganCoverCount).isEqualTo(veganCoverCountExpected);
    }

    @Test
    public void one_omnivorous_in_one_meal_should_return_1() {
        List<Cover> covers = new ArrayList<>();
        covers.add(omnivorous);
        CoverCounter coverCounter = new CoverCounter(covers);

        long omnivorousCoverCount = coverCounter.countForDiet(DietType.OMNIVOROUS);

        long omnivorousCoverCountExpected = 1;
        assertThat(omnivorousCoverCount).isEqualTo(omnivorousCoverCountExpected);
    }

    @Test
    public void three_omnivorous_and_one_vegan_in_one_meal_should_return_three() {
        List<Cover> covers = new ArrayList<>();
        covers.add(omnivorous);
        covers.add(omnivorous);
        covers.add(omnivorous);
        covers.add(vegan);
        CoverCounter coverCounter = new CoverCounter(covers);

        long omnivorousCoverCount = coverCounter.countForDiet(DietType.OMNIVOROUS);

        long omnivorousCoverCountExpected = 3;
        assertThat(omnivorousCoverCount).isEqualTo(omnivorousCoverCountExpected);
    }
}
