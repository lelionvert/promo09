package fr.socrates;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class RegistrationTest {

    private static final LocalDateTime dateTimeLimiteFirstMealService = LocalDateTime.of(2019, 4, 18, 21, 0);
    private SocratesEvent socratesEvent = new SocratesEvent(dateTimeLimiteFirstMealService, 40, 6);

    @Test
    public void single_room_with_all_meals() {
        Registration registration = new Registration(Room.SINGLE, dateTimeLimiteFirstMealService.minusHours(3), socratesEvent);
        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.SINGLE.price + 40 * 6);
    }

    @Test
    public void double_room_with_all_meals() {
        Registration registration = new Registration(Room.DOUBLE, dateTimeLimiteFirstMealService.minusHours(2), socratesEvent);

        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.DOUBLE.price + 40 * 6);
    }

    @Test
    public void triple_room_with_all_meals() {
        Registration registration = new Registration(Room.TRIPLE, dateTimeLimiteFirstMealService.minusHours(1), socratesEvent);

        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.TRIPLE.price + 40 * 6);
    }

    @Test
    public void no_room_with_all_meals() {
        Registration registration = new Registration(Room.NONE, dateTimeLimiteFirstMealService.minusHours(1), socratesEvent);

        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.NONE.price + 40 * 6);
    }

    @Test
    public void arrive_one_day_after_first_day_remove_one_meal() {
        Registration registration = new Registration(Room.SINGLE, dateTimeLimiteFirstMealService.plusDays(1), socratesEvent);

        int totalPrice = registration.calculatePrice();
        assertThat(totalPrice).isEqualTo(Room.SINGLE.price + (240 - 40 * 1));
    }

    @Test
    public void arrive_first_day_after_21h_remove_one_meal() {
        Registration registration = new Registration(Room.SINGLE, dateTimeLimiteFirstMealService.plusHours(1), socratesEvent);

        int totalPrice = registration.calculatePrice();
        assertThat(totalPrice).isEqualTo(Room.SINGLE.price + (240 - 40 * 1));
    }


}
