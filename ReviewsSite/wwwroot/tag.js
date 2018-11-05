document.addEventListener("DOMContentLoaded", (event) => {
    refreshTags();
    const saveTags = document.querySelector("#save-tag");
    saveTags.addEventListener("click", createTag);
});

function createTag() {
    const tagInput = document.querySelector("#new-tag");
    const newTagText = tagInput.value;
    const newTag = {
        text: newTagText,
        reviewId: reviewId
    };
    fetch(`/api/tag?reviewId=${reviewId}`, {
        method: 'POST',
        body: JSON.stringify(newTag),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(() => {
        tagInput.value = "";
        refreshTags();
    });
}

function refreshTags() {
    const ol = document.querySelector("#tags-list");
    ol.innerHTML = " ";

    fetch(`/api/tag/${reviewId}`)
        .then(res => res.json())
        .then(data => {
            data.forEach(c => addTagToDom(c));
        });
}

function addTagToDom(tag) {
    const a = document.createElement('a');
    a.href = `/tag/details/${tag.id}`;
    a.innerHTML = `${tag.text}`;
    const li = document.createElement('li');
    li.appendChild(a);
    const ol = document.querySelector("#tags-list");
    ol.appendChild(li);
}