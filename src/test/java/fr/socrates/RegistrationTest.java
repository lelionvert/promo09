package fr.socrates;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class RegistrationTest {
    @Test
    public void single_room_with_all_meals() {
        Registration registration = new Registration();

        int result = registration.calculatePrice(Room.SINGLE);

        assertThat(result).isEqualTo(850);
    }

    @Test
    public void double_room_with_all_meals() {
        Registration registration = new Registration();

        int result = registration.calculatePrice(Room.DOUBLE);

        assertThat(result).isEqualTo(750);
    }

    @Test
    public void triple_room_with_all_meals() {
        Registration registration = new Registration();
        int result = registration.calculatePrice(Room.TRIPLE);
        assertThat(result).isEqualTo(650);
    }

    @Test
    public void no_room_with_all_meals() {
        Registration registration = new Registration();

        int result = registration.calculatePrice(Room.NONE);

        assertThat(result).isEqualTo(480);
    }

    @Test
    public void single_room_without_first_meal() {
        CheckIn checkIn = new CheckIn(LocalDateTime.of(2019, 1, 2, 18, 0));

        Registration registration = new Registration(checkIn, LocalDateTime.of(2019, 1, 1, 7, 0));

        int result = registration.calculatePrice(Room.SINGLE);
        assertThat(result).isEqualTo(810);
    }
}
