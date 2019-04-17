package fr.socrates;

import org.junit.Test;

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
}
