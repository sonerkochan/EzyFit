import React, { useEffect, useState } from "react";
import { Text, View, FlatList } from "react-native";

type Muscle = {
  id: number; // or string, depending on your model
  name: string;
  // add other properties if you want
};

export default function Index() {
  const [muscles, setMuscles] = useState<Muscle[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch("http://192.168.2.167:5069/api/muscles") // replace with your actual API URL
      .then((res) => res.json())
      .then((data) => {
        setMuscles(data);
        setLoading(false);
      })
      .catch((err) => {
        console.error("Failed to fetch muscles:", err);
        setLoading(false);
      });
  }, []);

  if (loading) {
    return (
      <View
        style={{
          flex: 1,
          justifyContent: "center",
          alignItems: "center",
        }}
      >
        <Text>Loading muscles...</Text>
      </View>
    );
  }

  return (
    <View
      style={{
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
        padding: 20,
      }}
    >
      <Text style={{ fontSize: 20, marginBottom: 10 }}>Muscles List:</Text>
      <FlatList
        data={muscles}
        keyExtractor={(item) => item.id.toString()}
        renderItem={({ item }) => <Text>{item.name}</Text>}
      />
    </View>
  );
}
