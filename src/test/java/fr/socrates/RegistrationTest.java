package fr.socrates;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class RegistrationTest {
    @Test
    public void single_room_with_all_meals() {
        Registration registration = new Registration();
        int result = registration.calculatePrice(Room.SINGLE);

        assertThat(result).isEqualTo(650);
    }
}
