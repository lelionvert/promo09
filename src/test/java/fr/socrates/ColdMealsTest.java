package fr.socrates;

import org.junit.Test;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import static fr.socrates.SocratesOrga.countColdMeals;
import static org.assertj.core.api.Assertions.assertThat;

public class ColdMealsTest {

    @Test
    public void zero_participant_return_zero_cold_meal() {
        List<Participant> participants = Collections.emptyList();

        int result = countColdMeals(participants);

        assertThat(result).isEqualTo(0);
    }

    @Test
    public void list_participant_null_return_zero() {
        List<Participant> participants = new ArrayList<>();
        Participant participant = new Participant(null);

        participants.add(participant);

        int result = countColdMeals(participants);

        assertThat(result).isEqualTo(0);
    }

    @Test
    public void one_participant_after_thursday_21h() {
        List<Participant> participants = new ArrayList<>();
        LocalDateTime date = LocalDateTime.of(2019, 4, 18, 22, 9);
        Participant participant = new Participant(date);
        participants.add(participant);

        int result = countColdMeals(participants);

        assertThat(result).isEqualTo(1);
    }
}
