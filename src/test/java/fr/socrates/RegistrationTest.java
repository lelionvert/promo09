package fr.socrates;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class RegistrationTest {

    private static final LocalDateTime socratesStart = LocalDateTime.of(2019, 1, 2, 21, 0);
    private SocratesEvent socratesEvent = new SocratesEvent(socratesStart, 40, 6);

    @Test
    public void single_room_with_all_meals() {
        Registration registration = new Registration(Room.SINGLE, socratesStart, socratesEvent);
        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.SINGLE.price + 40 * 6);
    }

    @Test
    public void double_room_with_all_meals() {
        Registration registration = new Registration(Room.DOUBLE, socratesStart, socratesEvent);

        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.DOUBLE.price + 40 * 6);
    }

    @Test
    public void triple_room_with_all_meals() {
        Registration registration = new Registration(Room.TRIPLE, socratesStart, socratesEvent);

        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.TRIPLE.price + 40 * 6);
    }

    @Test
    public void no_room_with_all_meals() {
        Registration registration = new Registration(Room.NONE, socratesStart, socratesEvent);

        int totalPrice = registration.calculatePrice();

        assertThat(totalPrice).isEqualTo(Room.NONE.price + 40 * 6);
    }

    @Test
    public void single_room_without_first_meal() {
        Registration registration = new Registration(Room.SINGLE, socratesStart.plusDays(1), socratesEvent);

        int totalPrice = registration.calculatePrice();
        assertThat(totalPrice).isEqualTo(Room.SINGLE.price + (240 - 40 * 1));
    }
}
