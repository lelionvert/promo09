package fr.socrates;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class RegistrationTest {

    private static final LocalDateTime socratesStart = LocalDateTime.of(2019, 1, 2, 21, 0);
    private SocratesEvent socratesEvent = new SocratesEvent(socratesStart, new Meal(40, 6));

    @Test
    public void single_room_with_all_meals() {
        Registration registration = new Registration(Room.SINGLE, socratesEvent);

        int result = registration.calculatePrice();

        assertThat(result).isEqualTo(850);
    }

    @Test
    public void double_room_with_all_meals() {
        Registration registration = new Registration(Room.DOUBLE, socratesEvent);

        int result = registration.calculatePrice();

        assertThat(result).isEqualTo(750);
    }

    @Test
    public void triple_room_with_all_meals() {
        Registration registration = new Registration(Room.TRIPLE, socratesEvent);

        int result = registration.calculatePrice();

        assertThat(result).isEqualTo(650);
    }

    @Test
    public void no_room_with_all_meals() {
        Registration registration = new Registration(Room.NONE, socratesEvent);

        int result = registration.calculatePrice();

        assertThat(result).isEqualTo(480);
    }

    @Test
    public void single_room_without_first_meal() {
        CheckIn checkIn = new CheckIn(socratesStart.plusDays(1));

        Registration registration = new Registration(Room.SINGLE, checkIn, socratesEvent);

        int result = registration.calculatePrice();
        assertThat(result).isEqualTo(810);
    }
}
