import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class ColdMealsTest {
    @Test
    public void zero_participant_return_zero_cold_meal() {

        SocratesOrga socratesOrga = new SocratesOrga();
        int result = socratesOrga.countColdMeals();
        assertThat(result).isEqualTo(0);
    }


}
