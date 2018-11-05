document.addEventListener("DOMContentLoaded", (event) => {
    refreshComments();
    const saveComment = document.querySelector("#save-comment");
    saveComment.addEventListener("click", createTag);
});

function createTag() { 
    const commentInput = document.querySelector("#new-comment");
    const newCommentText = commentInput.value;
    const newComment = {
        text: newCommentText,
        reviewId: reviewId
    };
    fetch('/api/comment', {
        method: 'POST',
        body: JSON.stringify(newComment),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(() => {
        commentInput.value = "";
        refreshComments();
    });
}

function refreshComments() {
    const ol = document.querySelector("#comment-list");
    ol.innerHTML = "";

    fetch(`/api/comment/${reviewId}`)
        .then(res => res.json())
        .then(data => {
            data.forEach(c => addCommentToDom(c));
        });
}

function addCommentToDom(comment) {
    const li = document.createElement('li');
    const date = new Date(comment.createdAt);
    li.innerHTML = `${comment.text} <div class="comment-date">${date.toDateString()}</div>`;
    const ol = document.querySelector("#comment-list");
    ol.appendChild(li);
}